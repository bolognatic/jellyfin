﻿using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Library;

namespace MediaBrowser.Controller.Sorting
{
    /// <summary>
    /// Represents a BaseItem comparer that requires a User to perform it's comparison
    /// </summary>
    public interface IUserBaseItemComparer : IBaseItemComparer
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        User User { get; set; }

        /// <summary>
        /// Gets or sets the user manager.
        /// </summary>
        /// <value>The user manager.</value>
        IUserManager UserManager { get; set; }
    }
}
