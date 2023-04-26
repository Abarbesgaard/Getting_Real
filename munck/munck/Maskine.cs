using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munck
{
    public class Maskine
    {
        // Definer felter
        private string _maskineId;
        private string _lokationId;
        private MaskineType _maskinensType;
        private static int _antalMaskiner = 0;

        // Definer properties ud fra felterne
        public string MaskineId
        {
            get { return _maskineId; }
            set { _maskineId = value; }
        }

        public string LokationId
        {
            get { return _lokationId; }
            set { _lokationId = value; }
        }

        public MaskineType MaskinensType
        {
            get { return _maskinensType; }
            set { _maskinensType = value; }
        }

        public static int AntalMaskiner
        {
            get { return _antalMaskiner; }
        }

        // Constructor
        public Maskine(string MaskineId, string LokationId, MaskineType MaskinensType)
        {
            _maskineId = MaskineId;
            _lokationId = LokationId;
            _maskinensType = MaskinensType;
            Maskine._antalMaskiner += 1;
        }

    }
}
