// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Translator.DocumentTranslation
{
    /// <summary> Definition for the input batch translation request. </summary>
    public partial class DocumentTranslationInput
    {
        /// <summary> Initializes a new instance of DocumentTranslationInput. </summary>
        /// <param name="source"> Source of the input documents. </param>
        /// <param name="targets"> Location of the destination for the output. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> or <paramref name="targets"/> is null. </exception>
        public DocumentTranslationInput(TranslationSource source, IEnumerable<TranslationTarget> targets)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (targets == null)
            {
                throw new ArgumentNullException(nameof(targets));
            }

            Source = source;
            Targets = targets.ToList();
        }

        /// <summary> Source of the input documents. </summary>
        public TranslationSource Source { get; }
        /// <summary> Location of the destination for the output. </summary>
        public IList<TranslationTarget> Targets { get; }
        /// <summary> Storage type of the input documents source string. </summary>
        public StorageInputType? StorageType { get; set; }
    }
}
