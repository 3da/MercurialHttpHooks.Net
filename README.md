# MercurialHttpHooks.Net

MercurialHttpHooks gives you a chance to process Mercurial Hooks using custom HTTP server.
https://github.com/3da/MercurialHttpHooks

This project just provide .Net classes that correspond to protocol of communication with MercurialHttpHooks.

Sample project is provided.
Example code:
```
        [HttpPost]
        [Route("permissions")]
        public ProcessResult Post([FromBody] PushInfo obj)
        {
            if (obj.Commits.All(q => q.Message.Length > 10))
                return new ProcessResult()
                {
                    Success = true,
                    Message = "Good job\nDude"
                };

            return new ProcessResult
            {
                Success = false,
                Message = "Sorry but no"
            };
        }
```

This code means to deny all commits which message length is less or equal 10.
