﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellEditor.Sources.DBC
{
    class SpellVisualPrecastTransitions : AbstractDBC
    {
        public SpellVisualPrecastTransitions()
        {
            ReadDBCFile(Config.Config.DbcDirectory + "\\SpellVisualPrecastTransitions.dbc");
        }
    }
}
