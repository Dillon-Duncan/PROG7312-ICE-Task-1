using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ST10079970_PROG7312_ICE_Task_1
{
    public class Convict
    {
        private int convictID, senetnce, cellNumber;
        private string name, surname, crime;

        public Convict(int convictID, int senetnce, int cellNumber, string name, string surname, string crime)
        {
            this.convictID = convictID;
            this.senetnce = senetnce;
            this.cellNumber = cellNumber;
            this.name = name;
            this.surname = surname;
            this.crime = crime;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.convictID;

                    case 1:
                        return this.senetnce;

                    case 2:
                        return this.cellNumber;

                    case 3:
                        return this.name;

                    case 4:
                        return this.surname;

                    case 5:
                        return this.crime;

                    default:
                        return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.convictID = (int)value;
                        break;

                    case 1:
                        this.senetnce = (int)value;
                        break;

                    case 2:
                        this.cellNumber = (int)value;
                        break;

                    case 3:
                        this.name = (string)value;
                        break;

                    case 4:
                        this.surname = (string)value;
                        break;

                    case 5:
                        this.crime = (string)value;
                        break;

                    default:
                        break;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                switch (attrName.ToLower())
                {
                    case "convictid":
                        return this.convictID;

                    case "sentence":
                        return this.senetnce;

                    case "cellnumber":
                        return this.cellNumber;

                    case "name":
                        return this.name;

                    case "surname":
                        return this.surname;

                    case "crime":
                        return this.crime;

                    default:
                        return null;
                }
            }
            set
            {
                switch (attrName.ToLower())
                {
                    case "convictid":
                        this.convictID = (int)value;
                        break;

                    case "sentence":
                        this.senetnce = (int)value;
                        break;

                    case "cellnumber":
                        this.cellNumber = (int)value;
                        break;

                    case "name":
                        this.name = (string)value;
                        break;

                    case "surname":
                        this.surname = (string)value;
                        break;

                    case "crime":
                        this.crime = (string)value;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}