namespace ReactNETDashboard.Repository
{
	public interface IDataStore
	{
		decimal[] GetData(int numberOfDataPoints = 100);
	}
}