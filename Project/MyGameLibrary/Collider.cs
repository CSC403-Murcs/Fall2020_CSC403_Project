using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Collider {
    private Rectangle rect;
    public Collider(Rectangle rect) {
      this.rect = rect;
    }

    public void MovePosition(int x, int y) {
      rect.X = x;
      rect.Y = y;
    }

    public bool Intersects(Collider c) {
      return rect.IntersectsWith(c.rect);
    }
    public double noticeRadius() { 
      double radius = 1;
      return radius;
    }

    public double calculateDistance(Player p) { 
      double distance = Math.Sqrt((p.Collider.rect.X - rect.X)*(p.Collider.rect.X - rect.X) + (p.Collider.rect.Y - rect.Y)*(p.Collider.rect.Y - rect.Y));
      return distance;
    }
    public bool notices(Player p)
    {
        bool noticed = false;
        if (noticeRadius() > calculateDistance(p))
        {
            Random rng = new Random();
            int val = rng.Next(1, 20);
            if (val > p.noticeThreshold) { 
                noticed = true;     
            }
        }
        return noticed;
    }
    }
}
