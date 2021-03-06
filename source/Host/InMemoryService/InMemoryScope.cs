﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen, Bert Hoorne
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityAdmin.Host.InMemoryService
{
    public class InMemoryScope 
    {
        public InMemoryScope()
        {
            ScopeClaims = new List<InMemoryScopeClaim>();
            ScopeSecrets = new List<InMemoryScopeSecret>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClaimsRule { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public bool Enabled { get; set; }
        public bool IncludeAllClaimsForUser { get; set; }
        public bool Required { get; set; }
        public ICollection<InMemoryScopeClaim> ScopeClaims { get; set; }
        public ICollection<InMemoryScopeSecret> ScopeSecrets { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public int Type { get; set; }
    
        public bool AllowUnrestrictedIntrospection { get; set; }
    }

    public class InMemoryScopeClaim
    {
        public bool AlwaysIncludeInIdToken { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InMemoryScopeSecret
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; }
        public virtual string Value { get; set; }
    }
}