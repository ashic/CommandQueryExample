﻿using System.Collections.Generic;

namespace CommandQueryExample.Common.StandardCommands
{
    public class UpdateManyCommand<T> : CommandBase<T> where T : class
    {
        public UpdateManyCommand(IEnumerable<T> items)
        {
            _action = s =>
            {
                foreach (var item in items)
                    MarkAsModified(item);
            };
        }
    }
}