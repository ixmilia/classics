﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace IxMilia.Classics.ProcessFile
{
    public class PrepositionEntry : DictionaryEntry
    {
        public PrepositionEntry(string entry, string definition, string flags)
            : base(entry, definition, flags)
        {
        }

        public override PartOfSpeech PartOfSpeech => PartOfSpeech.Preposition;
    }
}