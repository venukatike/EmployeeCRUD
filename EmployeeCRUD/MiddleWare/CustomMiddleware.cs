namespace EmployeeCRUD.MiddleWare
{
    public class CustomMiddleware 
    {
        private readonly RequestDelegate _request;
        public CustomMiddleware(RequestDelegate request)
        {
            _request = request;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _request(context); // call the next middleware 

            if (context.Response.StatusCode == 500)
            {
                // You can add custom logic here for 500 errors if needed
                // For now, just return after the response is set
                return;
            }
        }
    }
}
