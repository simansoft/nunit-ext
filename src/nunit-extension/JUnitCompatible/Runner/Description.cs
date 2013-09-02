/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace Simansoft.NUnitExtension.JUnitCompatible.Runner
{
    public class Description
    {
        public string GetDisplayName()
        {
            throw new NotImplementedException();
        }

        public void AddChild(Description description)
        {
            throw new NotImplementedException();
        }

        public IList<Description> GetChildren()
        {
            throw new NotImplementedException();
        }

        public bool IsSuite()
        {
            throw new NotImplementedException();
        }

        public bool IsTest()
        {
            throw new NotImplementedException();
        }

        public int TestCount()
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return GetDisplayName();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public Description ChildlessCopy()
        {
            throw new NotImplementedException();
        }

        public T GetAttribute<T>() where T : Attribute
        {
            throw new NotImplementedException();
        }

        public ICollection<Attribute> GetAttributes()
        {
            throw new NotImplementedException();
        }

        public Type GetTestClass()
        {
            throw new NotImplementedException();
        }

        public string GetClassName()
        {
            throw new NotImplementedException();
        }

        public string GetMethodName()
        {
            throw new NotImplementedException();
        }
    }
}
