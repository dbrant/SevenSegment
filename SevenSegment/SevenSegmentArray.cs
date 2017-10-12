using System;
using System.Windows.Forms;
using System.Drawing;

/*
 * Seven-segment LED array control for .NET
 * (uses the original seven-segment LED control)
 * 
 * Copyright 2009-2017 Dmitry Brant. All Rights Reserved.
 * me@dmitrybrant.com
 * http://dmitrybrant.com
 * 
 * This component is free for personal use.
 * If you would like to use it in a commercial application, please
 * e-mail me at the address above.
 * This software comes as-is, with no warranty.
 * 
 * Features:
 * - Arbitrary number of array elements
 * - All the customizable settings of the original 7-seg control
 * - Accepts a string as a value, and distributes the characters
 *   among the array elements, automatically handling decimal points.
 * 
 */

namespace DmitryBrant.CustomControls
{
    public class SevenSegmentArray : UserControl
    {
        /// <summary>
        /// Array of segment controls that are currently children of this control.
        /// </summary>
        private SevenSegment[] segments = null;

        private int elementWidth = 10;
        private float italicFactor = 0.0F;
        private Color colorBackground = Color.DarkGray;
        private Color colorDark = Color.DimGray;
        private Color colorLight = Color.Red;
        private bool showDot = true;
        private Padding elementPadding;

        private string theValue = null;

        public SevenSegmentArray()
        {
            SuspendLayout();
            Name = "SevenSegmentArray";
            Size = new Size(100, 25);
            Resize += new EventHandler(SevenSegmentArray_Resize);
            ResumeLayout(false);

            TabStop = false;
            elementPadding = new Padding(4, 4, 4, 4);
            RecreateSegments(4);
        }

        /// <summary>
        /// Change the number of elements in our LED array. This destroys
        /// the previous elements, and creates new ones in their place, applying
        /// all the current options to the new ones.
        /// </summary>
        /// <param name="count">Number of elements to create.</param>
        private void RecreateSegments(int count)
        {
            if (segments != null)
                for (int i = 0; i < segments.Length; i++) { segments[i].Parent = null; segments[i].Dispose(); }

            if (count <= 0) return;
            segments = new SevenSegment[count];

            for (int i = 0; i < count; i++)
            {
                segments[i] = new SevenSegment();
                segments[i].Parent = this;
                segments[i].Top = 0;
                segments[i].Height = Height;
                segments[i].Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                segments[i].Visible = true;
            }

            ResizeSegments();
            UpdateSegments();
            Value = theValue;
        }

        /// <summary>
        /// Align the elements of the array to fit neatly within the
        /// width of the parent control.
        /// </summary>
        private void ResizeSegments()
        {
            int segWidth = Width / segments.Length;
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].Left = Width * (segments.Length - 1 - i) / segments.Length;
                segments[i].Width = segWidth;
            }
        }

        /// <summary>
        /// Update the properties of each element with the properties
        /// we have stored.
        /// </summary>
        private void UpdateSegments()
        {
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i].ColorBackground = colorBackground;
                segments[i].ColorDark = colorDark;
                segments[i].ColorLight = colorLight;
                segments[i].ElementWidth = elementWidth;
                segments[i].ItalicFactor = italicFactor;
                segments[i].DecimalShow = showDot;
                segments[i].Padding = elementPadding;
            }
        }

        private void SevenSegmentArray_Resize(object sender, EventArgs e) { ResizeSegments(); }

        protected override void OnPaintBackground(PaintEventArgs e) { e.Graphics.Clear(colorBackground); }

        /// <summary>
        /// Background color of the LED array.
        /// </summary>
        public Color ColorBackground { get { return colorBackground; } set { colorBackground = value; UpdateSegments(); } }
        /// <summary>
        /// Color of inactive LED segments.
        /// </summary>
        public Color ColorDark { get { return colorDark; } set { colorDark = value; UpdateSegments(); } }
        /// <summary>
        /// Color of active LED segments.
        /// </summary>
        public Color ColorLight { get { return colorLight; } set { colorLight = value; UpdateSegments(); } }

        /// <summary>
        /// Width of LED segments.
        /// </summary>
        public int ElementWidth { get { return elementWidth; } set { elementWidth = value; UpdateSegments(); } }
        /// <summary>
        /// Shear coefficient for italicizing the displays. Try a value like -0.1.
        /// </summary>
        public float ItalicFactor { get { return italicFactor; } set { italicFactor = value; UpdateSegments(); } }
        /// <summary>
        /// Specifies if the decimal point LED is displayed.
        /// </summary>
        public bool DecimalShow { get { return showDot; } set { showDot = value; UpdateSegments(); } }

        /// <summary>
        /// Number of seven-segment elements in this array.
        /// </summary>
        public int ArrayCount { get { return segments.Length; } set { if ((value > 0) && (value <= 100)) RecreateSegments(value); } }
        /// <summary>
        /// Padding that applies to each seven-segment element in the array.
        /// Tweak these numbers to get the perfect appearance for the array of your size.
        /// </summary>
        public Padding ElementPadding { get { return elementPadding; } set { elementPadding = value; UpdateSegments(); } }

        /// <summary>
        /// The value to be displayed on the LED array. This can contain numbers,
        /// certain letters, and decimal points.
        /// </summary>
        public string Value
        {
            get { return theValue; }
            set
            {
                theValue = value;
                for (int i = 0; i < segments.Length; i++) { segments[i].CustomPattern = 0; segments[i].DecimalOn = false; }
                if (theValue != null)
                {
                    int segmentIndex = 0;
                    for (int i = theValue.Length - 1; i >= 0; i--)
                    {
                        if (segmentIndex >= segments.Length) break;
                        if (theValue[i] == '.') segments[segmentIndex].DecimalOn = true;
                        else segments[segmentIndex++].Value = theValue[i].ToString();
                    }
                }
            }
        }

    }
}
