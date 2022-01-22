using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Project
{
    class Animals
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string nickname;

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        private string dateOfBirth;

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private string typeOfAnimal;

        public string TypeOfAnimal
        {
            get { return typeOfAnimal; }
            set { typeOfAnimal = value; }
        }

        private string purpose;

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        private string food;

        public string Food
        {
            get { return food; }
            set { food = value; }
        }


        public Animals()
        {

        }

        public Animals(string food ,string purpose ,int id, string name, string nickname, string dateOfBirth, string gender, string typeOfAnimal)
        {
            this.id = id;
            this.purpose = purpose;
            this.name = name;
            this.nickname = nickname;
            this.typeOfAnimal = typeOfAnimal;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.food = food;
        }
    }
}
