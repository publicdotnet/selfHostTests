using Owin;

public class Startup
{
    public void Configuration(IAppBuilder app)
    {
        app.Run(context =>
        {
            return context.Response.WriteAsync("Hello, OWIN Self-Hosted World!");
        });
    }
}
