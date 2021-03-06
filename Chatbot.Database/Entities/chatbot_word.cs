﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chatbot.Database
{
    public class chatbot_word
    {
        [Key]
        public string symbol_id { get; set; }

        [Key]
        public string syllable_id { get; set; }

        public string explanation { get; set; }

        public virtual ICollection<chatbot_wordphrase> wordphrases { get; set; }

        public virtual chatbot_syllable syllable { get; set; }

        public virtual chatbot_symbol symbol { get; set; }

        public chatbot_word()
        {
        }
    }
}
