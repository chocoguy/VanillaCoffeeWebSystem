namespace WebApi.Helpers
{
    public class ControllerHelpers
    {

        public async Task<string> GetTextFromBodyReq(HttpRequest req)
        {
            if (!req.Body.CanSeek) { req.EnableBuffering(); }
            req.Body.Position = 0;

            var reader = new StreamReader(req.Body);
            var reqString = await reader.ReadToEndAsync().ConfigureAwait(false);

            return reqString;
        }

    }
}
