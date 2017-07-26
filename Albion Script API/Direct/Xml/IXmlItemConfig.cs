﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.Xml
{
    /// <summary>
	/// Contains configuration information about an item.
	/// </summary>
	public interface IXmlItemConfig
    {
        /// <summary>
        /// Retrieves the unique name of the item.
        /// </summary>
        /// <value>The unique name of the item.</value>
        string UniqueName { get; }

        /// <summary>
        /// Retrieves the weight of the item.
        /// </summary>
        /// <value>The weight of the item.</value>
        float Weight { get; }

        /// <summary>
        /// If this item config has an associated equipment config.
        /// </summary>
        bool HasEquipmentConfig { get; }

        /// <summary>
        /// The config containing information about this item when worn as equipment.
        /// </summary>
        IXmlEquipmentItemConfig EquipmentConfig { get; }
    }
}
