using System;
using System.ComponentModel.DataAnnotations;

namespace ClassAndPropertieExample
{
	

	public class User
	{

        public int Id { get; set; }
        public string Surname { get; set; }
		public string name { get; set; } 
        public int Age { get; set; }
        public string Gander { get; set; }
		public bool IsStatus { get; set; } = true;
		public string Email { get; set; }
		public string password { get; set; }

        public int sayi;
		private int age;
		//private string name;

		public int getAge()
		{
			return age;
		}
		public void setAge(int age)
		{
			this.age = age;
		}
		public string Name
		{
			get { return Name; }
			set { Name = value; }
		}
	}

}

