﻿/*
 * Tfs2Slack - http://github.com/kria/Tfs2Slack
 * 
 * Copyright (C) 2014 Kristian Adrup
 * 
 * This file is part of Tfs2Slack.
 * 
 * Tfs2Slack is free software: you can redistribute it and/or modify it
 * under the terms of the GNU General Public License as published by the
 * Free Software Foundation, either version 3 of the License, or (at your
 * option) any later version. See included file COPYING for details.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCore.Tfs2Slack.Notifications
{
    abstract class BaseNotification : INotification
    {
        public string TeamProjectCollection { get; set; }

        public int TotalLineCount { get; set; }

        public string Color { get; set; }

        public abstract IList<string> ToMessage(Configuration.BotElement bot);

        public abstract bool IsMatch(string collection, Configuration.EventRuleCollection eventRules);
    }
}
