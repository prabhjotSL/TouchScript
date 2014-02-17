﻿/*
 * @author Valentin Simonov / http://va.lent.in/
 */

using TouchScript.InputSources.Devices;

namespace TouchScript.InputSources
{
    /// <summary>
    /// Abstract touch input source.
    /// </summary>
    public interface IInputSource
    {
        /// <summary>
        /// An object used to change coordinates of touch points coming from this input source.
        /// </summary>
        ICoordinatesRemapper CoordinatesRemapper { get; set; }

        InputDevice InputDevice { get; set; }

    }
}