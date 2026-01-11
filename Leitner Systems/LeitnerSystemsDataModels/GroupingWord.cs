using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitner_Systems.LeitnerSystemsDataModels
{
    public class GroupingWord
    {
        public GroupingWord()
        {

        }

        [Key]
        public int Id { get; set; }

        public string BoxName { get; set; }

        public int GroupNum { get; set; }

        public int TimeNum { get; set; }

        public string TimeType { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
