using Zenject;
using System.Collections;
using UnityEngine.TestTools;

public class PlayerMovementTest : ZenjectIntegrationTestFixture
{
    private void CommonInstall()
    {
        // Setup initial state by creating game objects from scratch, loading prefabs/scenes, etc

        PreInstall();

        //Container.Bind<PlayerMovementPC>().FromNewComponentOnNewGameObject()
        //    .AsSingle().WithArguments(new PlayerMovementSettings(2, rigidbody2D));

        // Call Container.Bind methods

        PostInstall();
    }

    [UnityTest]
    public IEnumerator PlayerMovementTests()
    {
        CommonInstall();

        // Add test assertions for expected state
        // Using Container.Resolve or [Inject] fields
        yield break;
    }
}