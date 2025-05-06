using UnityEngine;

public class Flag : MonoBehaviour
{
    private IWindRespondable _windRespondable;

    public void SetWindRespond(IWindRespondable windRespondable) => _windRespondable = windRespondable;

    private void FixedUpdate()
    {
        _windRespondable.Respond();
    }
}
