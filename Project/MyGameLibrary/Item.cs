using System;
using System.Drawing;


namespace Fall2020_CSC403_Project.code
{

	public class Item
	{

		public Image Img { get; set; }

		private string type = null;

		public Item(string type)
		{
			this.type = type;
		}

		public string getType() {
			return this.type;
		}

		public void setType(string type) {
			this.type = type;
		}
	}
}