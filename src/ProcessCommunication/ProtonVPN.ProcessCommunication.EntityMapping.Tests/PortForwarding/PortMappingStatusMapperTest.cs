﻿/*
 * Copyright (c) 2023 Proton AG
 *
 * This file is part of ProtonVPN.
 *
 * ProtonVPN is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ProtonVPN is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with ProtonVPN.  If not, see <https://www.gnu.org/licenses/>.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProtonVPN.Common.PortForwarding;
using ProtonVPN.EntityMapping.Contracts;
using ProtonVPN.ProcessCommunication.Contracts.Entities.PortForwarding;
using ProtonVPN.ProcessCommunication.EntityMapping.PortForwarding;
using ProtonVPN.ProcessCommunication.EntityMapping.Tests.Common;

namespace ProtonVPN.ProcessCommunication.EntityMapping.Tests.PortForwarding
{
    [TestClass]
    public class PortMappingStatusMapperTest : EnumMapperTestBase<PortMappingStatus, PortMappingStatusIpcEntity>
    {
        protected override IMapper<PortMappingStatus, PortMappingStatusIpcEntity> CreateMapper()
        {
            return new PortMappingStatusMapper();
        }
    }
}