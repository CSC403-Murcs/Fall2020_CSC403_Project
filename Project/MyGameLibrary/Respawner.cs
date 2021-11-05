using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
	public class Respawner
	{
		public long RespawnTime {get; private set;}
		public Vector2 Position;

		public Enemy Enemy;
		public Collider Collider;
		public PictureBox PictureBox {get; private set;}
		public Color Color {get; private set;}

		public bool IsActive
		{
			get
			{
				return PictureBox.Visible;
			}
		}

		public Respawner(PictureBox pic, Enemy enemy)
		{
			PictureBox = pic;
			Position = new Vector2(pic.Location.X, pic.Location.Y);
			Enemy = enemy;
			Enemy.Img = pic.BackgroundImage;

			// Unfortunate duplication, but this is more sane than overriding colliders entirely
			Collider = enemy.Collider;
			RespawnTime = 0;
			enemy.Respawner = this;
		}

		public void SetRespawn()
		{
			PictureBox.Visible = false;
			RespawnTime = DateTime.Now.AddSeconds(Defs.RESPAWN_TIME).Ticks;
		}

		public void Respawn(Player player)
		{
			Enemy = new Enemy(Position, Collider, player);
			Enemy.Img = PictureBox.BackgroundImage;
			Enemy.Color = Color;
			Enemy.Respawner = this;
			PictureBox.Visible = true;
		}

		public void Update()
		{
			if (IsActive)
			{
				return;
			}

			if (RespawnTime <= DateTime.Now.Ticks)
			{
				Respawn(Game.player);
			}
		}

		public void SetColor(Color color)
		{
			Color = color;
			if (Enemy != null)
			{
				Enemy.Color = color;
			}
		}
	}
}