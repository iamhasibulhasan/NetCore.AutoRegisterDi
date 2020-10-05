﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

namespace Test.DifferentServices
{
    public class LocalService : ILocalService, IAnotherInterface
    {
        public bool IsPositive(int i)
        {
            return i >= 0;
        }

    }
}