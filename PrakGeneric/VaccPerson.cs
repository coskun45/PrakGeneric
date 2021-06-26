using System;
using System.Collections.Generic;
using System.Text;

namespace PrakGeneric
{
    public class VaccPerson
    {
        string name;
        string passNo;
        string adresse;
        public VaccPerson(string name, string passNo,string adresse)
        {
            this.name = name;
            this.passNo = passNo;
            this.adresse = adresse;
        }
        public override string ToString()
        {
            return ($"PassNO: {passNo}  Name: {name}    Adresse: {adresse}");
        }
    }
}
