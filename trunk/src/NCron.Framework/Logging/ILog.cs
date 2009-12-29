﻿/*
 * Copyright 2009 Joern Schou-Rode
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

using System;

namespace NCron.Framework.Logging
{
    public interface ILog : IDisposable
    {
        void Debug(Func<string> msgCallback);
        void Debug(Func<string> msgCallback, Func<Exception> exCallback);

        void Info(Func<string> msgCallback);
        void Info(Func<string> msgCallback, Func<Exception> exCallback);

        void Warn(Func<string> msgCallback);
        void Warn(Func<string> msgCallback, Func<Exception> exCallback);

        void Error(Func<string> msgCallback);
        void Error(Func<string> msgCallback, Func<Exception> exCallback);

        void Fatal(Func<string> msgCallback);
        void Fatal(Func<string> msgCallback, Func<Exception> exCallback);
    }
}