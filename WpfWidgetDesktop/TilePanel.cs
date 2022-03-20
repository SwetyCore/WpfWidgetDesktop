using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


//https://gitee.com/akwkevin/aistudio.-util.-layout/edit/master/Util.Panels/Panels/TilePanel/TilePanel.cs
namespace Util.Panels
{
    /// <summary>
    /// TilePanel
    /// 瀑布流布局
    /// </summary>
    public class TilePanel : Panel
    {

        #region 属性

        /// <summary>
        /// 容器内元素的高度
        /// </summary>
        public int TileHeight
        {
            get { return (int)GetValue(TileHeightProperty); }
            set { SetValue(TileHeightProperty, value); }
        }
        /// <summary>
        /// 容器内元素的高度
        /// </summary>
        public static readonly DependencyProperty TileHeightProperty =
            DependencyProperty.Register("TileHeight", typeof(int), typeof(TilePanel), new FrameworkPropertyMetadata(100, FrameworkPropertyMetadataOptions.AffectsMeasure));
        /// <summary>
        /// 容器内元素的宽度
        /// </summary>
        public int TileWidth
        {
            get { return (int)GetValue(TileWidthProperty); }
            set { SetValue(TileWidthProperty, value); }
        }
        /// <summary>
        /// 容器内元素的宽度
        /// </summary>
        public static readonly DependencyProperty TileWidthProperty =
            DependencyProperty.Register("TileWidth", typeof(int), typeof(TilePanel), new FrameworkPropertyMetadata(100, FrameworkPropertyMetadataOptions.AffectsMeasure));
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetWidthPix(DependencyObject obj)
        {
            return (int)obj.GetValue(WidthPixProperty);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        public static void SetWidthPix(DependencyObject obj, int value)
        {
            if (value > 0)
            {
                obj.SetValue(WidthPixProperty, value);
            }
        }
        /// <summary>
        /// 元素的宽度比例，相对于TileWidth
        /// </summary>
        public static readonly DependencyProperty WidthPixProperty =
            DependencyProperty.RegisterAttached("WidthPix", typeof(int), typeof(TilePanel), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetHeightPix(DependencyObject obj)
        {
            return (int)obj.GetValue(HeightPixProperty);
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        public static void SetHeightPix(DependencyObject obj, int value)
        {
            if (value > 0)
            {
                obj.SetValue(HeightPixProperty, value);
            }
        }
        /// <summary>
        /// 元素的高度比例，相对于TileHeight
        /// </summary>
        public static readonly DependencyProperty HeightPixProperty =
            DependencyProperty.RegisterAttached("HeightPix", typeof(int), typeof(TilePanel), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.AffectsParentMeasure));
        /// <summary>
        /// 排列方向
        /// </summary>
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }
        /// <summary>
        /// 排列方向
        /// </summary>
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(TilePanel), new FrameworkPropertyMetadata(Orientation.Horizontal, FrameworkPropertyMetadataOptions.AffectsMeasure));
        /// <summary>
        /// 格子数量
        /// </summary>
        public int TileCount
        {
            get { return (int)GetValue(TileCountProperty); }
            set { SetValue(TileCountProperty, value); }
        }
        /// <summary>
        /// 格子数量
        /// </summary>
        public static readonly DependencyProperty TileCountProperty =
            DependencyProperty.Register("TileCount", typeof(int), typeof(TilePanel), new FrameworkPropertyMetadata(4, FrameworkPropertyMetadataOptions.AffectsMeasure));
        /// <summary>
        /// Tile之间的间距
        /// </summary>
        public Thickness TileMargin
        {
            get { return (Thickness)GetValue(TileMarginProperty); }
            set { SetValue(TileMarginProperty, value); }
        }
        /// <summary>
        /// Tile之间的间距
        /// </summary>
        public static readonly DependencyProperty TileMarginProperty =
            DependencyProperty.Register("TileMargin", typeof(Thickness), typeof(TilePanel), new FrameworkPropertyMetadata(new Thickness(2), FrameworkPropertyMetadataOptions.AffectsMeasure));
        /// <summary>
        /// 最小的高度比例
        /// </summary>
        private int MinHeightPix { get; set; }
        /// <summary>
        /// 最小的宽度比例
        /// </summary>
        private int MinWidthPix { get; set; }

        #endregion

        #region 方法

        private Dictionary<FrameworkElement, Point> Location { get; set; }
        private List<Point> Maps { get; set; }
        private Tuple<Point, Point> SetMaps(Point childPosition, Size childPix)
        {
            Point lastNullPosition = childPosition;

            bool first = true;
            while (true)
            {
                if ((this.Orientation == System.Windows.Controls.Orientation.Horizontal && childPosition.X + childPix.Width <= this.TileCount)
                    || (this.Orientation == System.Windows.Controls.Orientation.Vertical && childPosition.Y + childPix.Height <= this.TileCount))
                {
                    List<Point> maps = new List<Point>();

                    for (int i = 0; i < childPix.Width; i++)
                    {
                        for (int j = 0; j < childPix.Height; j++)
                        {
                            maps.Add(new Point(childPosition.X + i, childPosition.Y + j));
                        }
                    }

                    //如果该区域没有被占用
                    if (maps.Except(Maps).Count() == maps.Count)
                    {
                        Maps.AddRange(maps);
                        if (first == true)
                        {
                            if (this.Orientation == System.Windows.Controls.Orientation.Horizontal)
                            {
                                lastNullPosition.X = lastNullPosition.X + childPix.Width;
                                if (lastNullPosition.X == this.TileCount)
                                {
                                    lastNullPosition.X = 0;
                                    lastNullPosition.Y++;
                                }
                            }
                            else
                            {
                                lastNullPosition.Y = lastNullPosition.Y + childPix.Height;
                                if (lastNullPosition.Y == this.TileCount)
                                {
                                    lastNullPosition.Y = 0;
                                    lastNullPosition.X++;
                                }
                            }
                        }
                        return new Tuple<Point, Point>(childPosition, lastNullPosition);
                    }
                }

                if (this.Orientation == System.Windows.Controls.Orientation.Horizontal)
                {
                    childPosition.X += childPix.Width;
                    if (childPosition.X >= this.TileCount)
                    {
                        childPosition.X = 0;
                        childPosition.Y++;
                    }
                }
                else
                {
                    childPosition.Y += childPix.Height;
                    if (childPosition.Y >= this.TileCount)
                    {
                        childPosition.Y = 0;
                        childPosition.X++;
                    }
                }

                first = false;
            }

        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size constraint)
        {
            Size childPix = new Size();
            Point childPosition = new Point();
            Point lastNullPosition = new Point();

            this.Maps = new List<Point>();
            this.Location = new Dictionary<FrameworkElement, Point>();

            int childWidthPix, childHeightPix = 0;

            if (this.Children.Count == 0) return new Size();
            //遍历孩子元素
            foreach (FrameworkElement child in this.Children)
            {
                child.Margin = this.TileMargin;
                child.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                child.VerticalAlignment = System.Windows.VerticalAlignment.Top;

                childWidthPix = TilePanel.GetWidthPix(child);
                childHeightPix = TilePanel.GetHeightPix(child);

                if (this.MinHeightPix == 0) this.MinHeightPix = childHeightPix;
                if (this.MinWidthPix == 0) this.MinWidthPix = childWidthPix;

                if (this.MinHeightPix > childHeightPix) this.MinHeightPix = childHeightPix;
                if (this.MinWidthPix > childWidthPix) this.MinWidthPix = childWidthPix;
            }

            foreach (FrameworkElement child in this.Children)
            {
                childPix.Width = TilePanel.GetWidthPix(child);
                childPix.Height = TilePanel.GetHeightPix(child);

                //maxRowCount += childWidthPix * childHeightPix;

                if (this.Orientation == System.Windows.Controls.Orientation.Vertical)
                {
                    if (childPix.Height > this.TileCount)
                    {
                        childPix.Height = this.TileCount;
                    }
                }
                else
                {
                    if (childPix.Width > this.TileCount)
                    {
                        childPix.Width = this.TileCount;
                    }
                }

                child.Width = this.TileWidth * childPix.Width + (child.Margin.Left + child.Margin.Right) * ((childPix.Width - this.MinWidthPix) / this.MinWidthPix);
                child.Height = this.TileHeight * childPix.Height + (child.Margin.Top + child.Margin.Bottom) * ((childPix.Height - this.MinHeightPix) / this.MinHeightPix);

                var positionInfo = this.SetMaps(lastNullPosition, childPix);
                childPosition = positionInfo.Item1;
                lastNullPosition = positionInfo.Item2;
                Location.Add(child, childPosition);

                child.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            }

            if (this.TileCount <= 0) throw new ArgumentOutOfRangeException();
            //if (this.MinWidthPix == 0) this.MinWidthPix = 1;
            //if (this.MinHeightPix == 0) this.MinHeightPix = 1;
            if (this.Orientation == Orientation.Horizontal)
            {
                this.Width = constraint.Width = this.TileCount * this.TileWidth + this.TileCount / this.MinWidthPix * (this.TileMargin.Left + this.TileMargin.Right);
                double heightPix = Maps.Max(p => p.Y) + 1;
                if (!double.IsNaN(heightPix))
                    constraint.Height = heightPix * this.TileHeight + heightPix / this.MinHeightPix * (this.TileMargin.Top + this.TileMargin.Bottom);
            }
            else
            {
                this.Height = constraint.Height = this.TileCount * this.TileHeight + this.TileCount / this.MinHeightPix * (this.TileMargin.Top + this.TileMargin.Bottom);
                double widthPix = Maps.Max(p => p.X) + 1;
                if (!double.IsNaN(widthPix))
                    constraint.Width = widthPix * this.TileWidth + widthPix / this.MinWidthPix * (this.TileMargin.Left + this.TileMargin.Right);
            }

            return constraint;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="finalSize"></param>
        /// <returns></returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            if (Location != null)
            {
                foreach (FrameworkElement child in this.Children)
                {
                    var childPosition = Location[child];

                    child.Arrange(new Rect(childPosition.X * this.TileWidth + Math.Floor(childPosition.X / this.MinWidthPix) * (this.TileMargin.Left + this.TileMargin.Right),
                                           childPosition.Y * this.TileHeight + Math.Floor(childPosition.Y / this.MinHeightPix) * (this.TileMargin.Top + this.TileMargin.Bottom),
                                           child.DesiredSize.Width, child.DesiredSize.Height));

                }
            }

            return finalSize;
        }
        #endregion
    }
}
