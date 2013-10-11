using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace A2MVC4.Models
{
    
    public class ArithClass
    {
       
        [Range(10, int.MaxValue)]
        public int N { get; set; }

       
        [Range(1, int.MaxValue)]        
        public int M { get; set; }


        public int S { get { return N + M; } }
        public int sum { get { return N + M; } }
        public int minus { get { return N - M; } }
        public int product { get { return N * M; } }
       
        public int division { get { if (M == 0) { return 0; } else { return N / M; } } }
        public int modulo { get { if (M == 0) { return 0; } else { return N % M; } } }

    }


}