using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace HangmanGame.Hangman_Source
{
    public class Hangman
    {
        public Canvas drawingPanel;
        /// <summary>
        /// Creates a new hangman
        /// </summary>
        /// <param name="drawingPanel">The panel where a hangman should be drawn</param>
        public Hangman(Canvas drawingPanel)
        {
            this.drawingPanel = drawingPanel;
        }

        /// <summary>
        /// The panel where a hangman should be drawn 
        /// </summary>
        public Canvas DrawingPanel
        {
            get { return this.drawingPanel; }
            set { this.drawingPanel = value; }
        }
        /// <summary>
        /// Draws hangman
        /// </summary>
        /// <param name="hangmanPart">Hangman parts</param>
        public void DrawHangman(HangmanParts hangmanPart)
        {
            if (hangmanPart == HangmanParts.BasisBeam)
            {
                Line basisBeam = new Line();
                basisBeam.Name = "BasisLine";
                basisBeam.Stroke = System.Windows.Media.Brushes.Brown;
                basisBeam.StrokeThickness = 12;
                basisBeam.X1 = 50;
                Canvas.SetTop(basisBeam, 204);
                Canvas.SetLeft(basisBeam, 4);
                this.DrawingPanel.Children.Add(basisBeam);
            }
            else if (hangmanPart == HangmanParts.VerticalBeam)
            {
                Line verticalBeam = new Line();
                verticalBeam.Name = "VerticalBeam";
                verticalBeam.Stroke = System.Windows.Media.Brushes.Brown;
                verticalBeam.StrokeThickness = 8;
                verticalBeam.Y1 = 170;
                Canvas.SetLeft(verticalBeam, 29);
                Canvas.SetTop(verticalBeam, 29);
                Canvas.SetBottom(verticalBeam, 12);
                this.DrawingPanel.Children.Add(verticalBeam);
            }
            else if (hangmanPart == HangmanParts.HorizontalBeam)
            {
                Line horizontalBeam = new Line();
                horizontalBeam.Name = "HorizontalBeam";
                horizontalBeam.Stroke = System.Windows.Media.Brushes.Brown;
                horizontalBeam.StrokeThickness = 8;
                horizontalBeam.X1 = 130;
                Canvas.SetLeft(horizontalBeam, 25);
                Canvas.SetTop(horizontalBeam, 26);
                this.DrawingPanel.Children.Add(horizontalBeam);
            }
            else if (hangmanPart == HangmanParts.HolderBeam)
            {
                Line holderBeam = new Line();
                holderBeam.Name = "HolderBeam";
                holderBeam.Stroke = System.Windows.Media.Brushes.Brown;
                holderBeam.StrokeThickness = 6;
                holderBeam.Y1 = 30;
                Canvas.SetLeft(holderBeam, 105);
                Canvas.SetTop(holderBeam, 28);
                this.DrawingPanel.Children.Add(holderBeam);
            }
            else if (hangmanPart == HangmanParts.Head)
            {
                Ellipse head = new Ellipse();
                head.Name = "Head";
                head.Stroke = System.Windows.Media.Brushes.White;
                head.StrokeThickness = 5;
                head.Width = 40;
                head.Height = 40;
                Canvas.SetLeft(head, 85);
                Canvas.SetTop(head, 58);
                this.DrawingPanel.Children.Add(head);
            }
            else if (hangmanPart == HangmanParts.Body)
            {
                Line body = new Line();
                body.Name = "Body";
                body.Stroke = System.Windows.Media.Brushes.White;
                body.StrokeThickness = 5;
                body.Y1 = 60;
                Canvas.SetLeft(body, 105);
                Canvas.SetTop(body, 97);
                this.DrawingPanel.Children.Add(body);
            }
            else if (hangmanPart == HangmanParts.LeftArm)
            {
                Line leftArm = new Line();
                leftArm.Name = "LeftArm";
                leftArm.Stroke = System.Windows.Media.Brushes.White;
                leftArm.StrokeThickness = 5;
                leftArm.X2 = 25;
                leftArm.Y1 = 30;
                Canvas.SetLeft(leftArm, 80);
                Canvas.SetTop(leftArm, 105);
                this.DrawingPanel.Children.Add(leftArm);
            }
            else if (hangmanPart == HangmanParts.RightArm)
            {
                Line rightArm = new Line();
                rightArm.Name = "RightArm";
                rightArm.Stroke = System.Windows.Media.Brushes.White;
                rightArm.StrokeThickness = 5;
                rightArm.X1 = 25;
                rightArm.Y1 = 30;
                Canvas.SetLeft(rightArm, 105);
                Canvas.SetTop(rightArm, 105);
                this.DrawingPanel.Children.Add(rightArm);
            }
            else if (hangmanPart == HangmanParts.LeftLeg)
            {
                Line leftLeg = new Line();
                leftLeg.Name = "LeftLeg";
                leftLeg.Stroke = System.Windows.Media.Brushes.White;
                leftLeg.StrokeThickness = 5;
                leftLeg.X2 = 25;
                leftLeg.Y1 = 30;
                Canvas.SetLeft(leftLeg, 80);
                Canvas.SetTop(leftLeg, 155);
                this.DrawingPanel.Children.Add(leftLeg);
            }
            else
            {
                Line rightLeg = new Line();
                rightLeg.Name = "LeftLeg";
                rightLeg.Stroke = System.Windows.Media.Brushes.White;
                rightLeg.StrokeThickness = 5;
                rightLeg.X1 = 25;
                rightLeg.Y1 = 30;
                Canvas.SetLeft(rightLeg, 105);
                Canvas.SetTop(rightLeg, 155);
                this.DrawingPanel.Children.Add(rightLeg);
            }
        }
    }
}
