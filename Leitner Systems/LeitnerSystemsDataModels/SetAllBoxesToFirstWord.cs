using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class SetAllBoxesToFirstWord
    {
        public SetAllBoxesToFirstWord()
        {
            
        }

        [Key]
        public int Id { get; set; }

        public bool IsChecked { get; set; }
    }
}
