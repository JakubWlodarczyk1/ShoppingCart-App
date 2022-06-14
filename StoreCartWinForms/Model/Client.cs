using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace StoreCartWinForms.Model
{
    //[Serializable]
    public class Client
    {
        //[XmlIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Product> Products { get; set; }
    }
}
