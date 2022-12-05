﻿using ApeFree.ApeForms.Core.Gdi.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ApeFree.ApeForms.Core.Gdi
{
    /// <summary>
    /// 图形面板基类
    /// </summary>
    /// <typeparam name="TStyle">绘制风格类型</typeparam>
    public abstract class Palette<TStyle> : IDisposable
    {
        /// <summary>
        /// 图层
        /// </summary>
        public IList<Layer<TStyle>> Layers { get; protected internal set; }

        /// <summary>
        /// 构造画板
        /// </summary>
        protected internal Palette()
        {
            Layers = new List<Layer<TStyle>>();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public abstract void Dispose();

        protected abstract void DrawLine(TStyle style, LineShape graphic);
        protected abstract void DrawEllipse(TStyle style, EllipseShape graphic);
    }

    /// <summary>
    /// 图形面板基类
    /// </summary>
    /// <typeparam name="TCanvas">画布类型</typeparam>
    /// <typeparam name="TStyle">绘制风格类型</typeparam>
    public abstract class Palette<TCanvas, TStyle> : Palette<TStyle>
    {
        /// <summary>
        /// 画布
        /// </summary>
        protected TCanvas Canvas { get; set; }

        /// <summary>
        /// 构造画板
        /// </summary>
        protected Palette() { }

        /// <summary>
        /// 构造画板
        /// </summary>
        /// <param name="canvas">画布对象</param>
        protected Palette(TCanvas canvas) : this()
        {
            Canvas = canvas;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public override void Dispose()
        {
            Layers.Clear();
            Layers = null;
        }
    }

    /// <summary>
    /// WinForm Gdi+图形画板
    /// </summary>
    public class GdiPalette : Palette<Graphics, GdiPalette.ShapeStyle>
    {
        protected override void DrawEllipse(ShapeStyle style, EllipseShape graphic)
        {
            if (style.Pen != null)
            {
                Canvas.DrawEllipse(style.Pen, graphic.Location.X, graphic.Location.Y, graphic.Size.Width, graphic.Size.Height);
            }

            if (style.Brush != null)
            {
                Canvas.FillEllipse(style.Brush, graphic.Location.X, graphic.Location.Y, graphic.Size.Width, graphic.Size.Height);
            }
        }

        protected override void DrawLine(ShapeStyle style, LineShape graphic)
        {
            Canvas.DrawLine(style.Pen, graphic.StartPoint, graphic.EndPoint);
        }

        /// <summary>
        /// 图形样式
        /// </summary>
        public class ShapeStyle
        {
            /// <summary>
            /// 画笔
            /// </summary>
            public Pen Pen { get; set; }

            /// <summary>
            /// 画刷
            /// </summary>
            public Brush Brush { get; set; }
        }
    }
}
