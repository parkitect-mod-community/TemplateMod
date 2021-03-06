﻿/**
* Copyright 2019 Some Indvidual
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
using System.Linq;

namespace Template
{
    public class Main : IMod
    {
        public string Path
        {
            get { return ModManager.Instance.getModEntries().First(x => x.mod == this).path; }
        }

        public void onEnabled()
        {

        }

        public void onDisabled()
        {
        }

        public string Name => "Template Mod";

        public string Description => "";

        string IMod.Identifier => "Template";
    }
}
