namespace WebApplication1.Service
{
    public class TestService : ITestService
    {

        private readonly ILogger<TestService> logger;
        public TestService(ILogger<TestService> logger)
        {
            this.logger = logger;
        }
        public void Show()
        {
			try
			{
                Console.WriteLine("欢迎光临");
                logger.LogInformation(DateTime.Now.ToString()+ ";TestService.Show"+"操作成功");
            }
			catch (Exception ex)
			{
                logger.LogError(DateTime.Now.ToString() + ";TestService.Show" + ex.Message);
                throw;
			}            
        }
    }
}
