using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {

        private String name;
        private int age;
        private bool isBelongs;
        private String occupation;
        private int id;

        public Usuario(String name, int age, bool isBelongs, String ocuppation, int id)
        {
            this.Name = name;
            this.Age = age;
            this.IsBelongs = isBelongs;
            this.Occupation = ocuppation;
            this.Id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsBelongs { get => isBelongs; set => isBelongs = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public int Id { get => id; set => id = value; }
    }
}
