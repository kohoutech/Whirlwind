/* ----------------------------------------------------------------------------
Whirlwind : an arpeggiator plugin for Patchworker 
Copyright (C) 1998-2019  George E Greaney

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
----------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Transonic.MIDI;
using PatchWorker.Plugin;

namespace Whirlwind
{
    class Whirlwind : IPatchPlugin
    {
        public void closePluginDialog()
        {
            throw new NotImplementedException();
        }

        public int getInputCount()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        public int getOutputCount()
        {
            throw new NotImplementedException();
        }

        public void handleMidiMessage(byte[] msg)
        {
            throw new NotImplementedException();
        }

        public void loadFromPatch(Origami.ENAML.EnamlData data, string dataPath)
        {
            throw new NotImplementedException();
        }

        public void saveToPatch(Origami.ENAML.EnamlData data, string dataPath)
        {
            throw new NotImplementedException();
        }

        public void setModifier(IPatchModifer modUnit)
        {
            throw new NotImplementedException();
        }

        public void showPluginDialog(string title)
        {
            throw new NotImplementedException();
        }
    }
}
