using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munck
{
    public class Bruger
    {
        // Definer felter
        private string _brugerId;
        private string _fornavn;
        private string _efternavn;
        private bool _adminAccess;

        // Definer properties ud fra felterne
        public string BrugerId
        {
            get { return _brugerId; }
            set { _brugerId = value; }
        }

        public string Fornavn
        {
            get { return _fornavn; }
            set { _fornavn = value; }
        }

        public string Efternavn
        {
            get { return _efternavn; }
            set { _efternavn = value; }
        }

        //Constructor
        public Bruger(string brugerId, string fornavn, string efternavn, bool adminAcces)
        {
            BrugerId = brugerId;
            Fornavn = fornavn;
            Efternavn = efternavn;
            _adminAccess = adminAcces;
        }

        // Metode til at ændre administratorrettigheder til en bruger
        public void ChangeAdminAccess(bool adminAccess)
        {
            _adminAccess = adminAccess;            
        }

        // Override af ToString til at returnere objektinformationer
        public override string ToString()
        {
            return $"brugerId: {_brugerId}, fornavn: {_fornavn}, efternavn: {_efternavn}, adminAccess: {_adminAccess}";
        }


    }
}
