﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Fluent
{
    public class CheckBox:ToggleButton
    {
        #region Constructors

        /// <summary>
        /// Static constructor
        /// </summary>
        static CheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox), new FrameworkPropertyMetadata(typeof(CheckBox)));            
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public CheckBox()
        {
            
        }

        #endregion
    }
}
