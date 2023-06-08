
// Build MediatR

var writter = new Writter();
var services = new ServiceCollection();

services.AddSingleton<IWritter, Writter>();
services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

services.AddScoped(typeof(IPipelineBehavior<,>), typeof(GenericPipelineBehavior<,>));
services.AddScoped(typeof(IStreamPipelineBehavior<,>), typeof(GenericStreamPipelineBehavior<,>));


var provider = services.BuildServiceProvider();

var mediatR = provider.GetRequiredService<IMediator>();

// Run Application

await Runner.Run(mediatR, writter);