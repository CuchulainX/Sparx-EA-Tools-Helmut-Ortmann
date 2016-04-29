﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace hoTools.EaServices
{
    public class ServiceCall
    {
        MethodInfo _method;
        string _GUID = "";
        string _Description = "";
        string _Help = "";
        bool _IsTextRequired;

        public ServiceCall(MethodInfo Method, string GUID, string Description, string Help, bool IsTextRequired)
        {
            _method = Method;
            _Description = Description;
            _GUID = GUID;
            _Help = Help;
            _IsTextRequired = IsTextRequired;
        }



        public String Description => this._Description;
        public MethodInfo Method => this._method;
        public string Help => this._Help;
        public String GUID => this._GUID;
    }
    /// <summary>
    /// Sort ServicesCalls against column Description. Use Interface IComparable.
    /// </summary>
    public class ServicesCallDescriptionComparer : IComparer<ServiceCall>
    {
        public int Compare(ServiceCall firstValue, ServiceCall secondValue)
        {
            if (firstValue == null && secondValue == null) return 0;
            if (firstValue == null) return 1;
            if (secondValue == null) return -1;
            return string.Compare(firstValue.Description, secondValue.Description, StringComparison.Ordinal);
        } 
    }
    /// <summary>
    /// Sort/Search ServicesCalls against column GUID. Use Interface IComparable.
    /// </summary>
    public class ServicesCallGUIDComparer : IComparer<ServiceCall>
    {
        public int Compare(ServiceCall firstValue, ServiceCall secondValue)
        {
            if (firstValue == null && secondValue == null) return 0;
            if (firstValue == null) return 1;
            if (secondValue == null) return -1;
            return string.Compare(firstValue.GUID, secondValue.GUID, StringComparison.Ordinal);
        }
    }
    /// <summary>
    /// Class to define the configurable services
    /// </summary>
    public class ServicesCallConfig
    {
        MethodInfo _method;
        string _GUID;
        int _pos;
        string _buttonText;
        string _description;
        string _help;
        bool _IsTextRequired;
        public ServicesCallConfig(int Pos, string GUID, string ButtonText)
        {
            _GUID = GUID;
            _pos = Pos;
            _buttonText = ButtonText;
        }
        public string Invoke(EA.Repository rep, string text)
        {
            object s = null;
            if (_method != null)
            {
                try {
                    // Invoke the method itself. The string returned by the method winds up in s
                    // substitute default parameter by Type.Missing
                    if (_IsTextRequired)
                    {
                        // use Type.Missing for optional parameters
                        switch (_method.GetParameters().Length)
                        {
                            case 1:
                                _method.Invoke(null, new object[] { rep, text });
                                break;
                            case 2:
                                _method.Invoke(null, new object[] { rep, text, Type.Missing });
                                break;
                            case 3:
                                _method.Invoke(null, new object[] { rep, text, Type.Missing, Type.Missing });
                                break;
                            default:
                                _method.Invoke(null, new object[] { rep, text, Type.Missing, Type.Missing, Type.Missing });
                                break;
                        }
                    }
                    else
                    {
                        // use Type.Missing for optional parameters
                        switch (_method.GetParameters().Length)
                        {
                            case 1:
                                _method.Invoke(null, new object[] { rep });
                                break;
                            case 2:
                                _method.Invoke(null, new object[] { rep, Type.Missing });
                                break;
                            case 3:
                                _method.Invoke(null, new object[] { rep, Type.Missing, Type.Missing });
                                break;
                            default:
                                _method.Invoke(null, new object[] { rep, Type.Missing, Type.Missing, Type.Missing });
                                break;
                        }

                    }
                } catch (Exception e)
                {
                    MessageBox.Show(e +  "\nCan't invoke " + _method.Name + "Return:'"+ _method.ReturnParameter + "' "+_method,"Error Invoking service");
                    return (string)s;
                }
            }
            return null;
        }
        public string Help
        {
            get
            {
                return this._help;

            }
            set
            {
                this._help = value;

            }
        }
        public MethodInfo Method
        {
            get
            {
                return this._method;

            }
            set
            {
                this._method = value;

            }
        }
        public string MethodName {
            get
            {
                if (this._method == null) return "";
                else return this._method.Name;
            }

        }
        public string Description
        {
            get
            {
                return this._description; 
            }
            set
            {
                this._description = value;
            }

        }
        public string HelpTextLong
        {
            get
            {
                if (MethodName == "") return "";
                return "MethodName\t:\t"+ MethodName + "()\nDescription1\t:\t" + Description + "\nDescription2\t:\t" + this._help;
            }

        }
        public int Pos => this._pos;
        public bool IsTextRequired
         {
             get
             {
                 return this._IsTextRequired;

             }
             set
             {
                 this._IsTextRequired = value;

             }
         }
         public string GUID
         {
             get
             {
                 return this._GUID;

             }
             set
             {
                this._GUID = value;

             }
         }
         public string ButtonText
         {
             get
             {
                 return this._buttonText;

             }
              set
             {
                 this._buttonText = value;

             }
         }
    }
}
