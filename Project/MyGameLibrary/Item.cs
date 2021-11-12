using System;
using System.Drawing;


namespace Fall2020_CSC403_Project.code
{

	public class Item
	{

		public Image Img { get; set; }

		public string Type {get; set; }

		public Item(string Type)
		{
			this.Type = Type;
		}
	}
}