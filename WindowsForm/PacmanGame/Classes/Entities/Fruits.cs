using PacmanGame.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGame.Classes.Entities
{
    class Fruits : AbstractEntity
    {
        private static string[] fruitsImages = { "Fruit_Apple.png", "Fruit_Strawberry.png", "Fruit_Cherry.png" };
        private string fileName;
        
        public Fruits(int row, int column) : base(100, row, column) 
        {
            int count = Fruits.fruitsImages.Length;
            int index = Dice.GetInstance().Next(0, count);
            this.fileName = Fruits.fruitsImages[index];
        }

        public override void Draw(Graphics g)
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            int side = Map.cellSize;
            Rectangle bounds = new Rectangle(x, y, side, side);
            Image myImage = Image.FromFile($"../Resources/{this.fileName}");
            g.DrawImage(myImage, bounds);

            myImage.Dispose();
        }
    }
}
