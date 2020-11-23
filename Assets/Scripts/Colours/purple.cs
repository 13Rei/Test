using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purple : MonoBehaviour
{
    public Material backgroundMaterial;
    public Material playerMaterial;
    public Material obstacleMaterial;
    public Material UI;
    public Material Target;

    private void OnMouseUp()
    {
        //Background colour
        backgroundMaterial.SetFloat("_redLevel", 0.613f);
        backgroundMaterial.SetFloat("_greenLevel", 0.379f);
        backgroundMaterial.SetFloat("_blueLevel", 0.605f);

        //Obstacle colour
        obstacleMaterial.SetFloat("_albedoRedLevel", 0.137f);
        obstacleMaterial.SetFloat("_albedoGreenLevel", 0f);
        obstacleMaterial.SetFloat("_albedoBlueLevel", 0.774f);

        //obstacle Emission
        obstacleMaterial.SetFloat("_redEmissionLevel", 0.778f);
        obstacleMaterial.SetFloat("_greenEmissionLevel", 0f);
        obstacleMaterial.SetFloat("_blueEmissionLevel", 0.358f);
        obstacleMaterial.SetFloat("_emissionPower", 0.55f);

        //Player Colour
        playerMaterial.SetFloat("_redAlbedoLevel", 0.258f);
        playerMaterial.SetFloat("_greenAlbedoLevel", 0f);
        playerMaterial.SetFloat("_blueAlbedoLevel", 0.899f);

        //Player Emission
        playerMaterial.SetFloat("_redEmissionLevel", 0.093f);
        playerMaterial.SetFloat("_greenEmissionLevel", 0f);
        playerMaterial.SetFloat("_blueEmissionLevel", 0.318f);
        playerMaterial.SetFloat("_emissionPower", 0f);

        //UI Colour
        UI.SetFloat("_redAlbedoLevel", 0.806f);
        UI.SetFloat("_greenAlbedoLevel", 0.229f);
        UI.SetFloat("_blueAlbedoLevel", 0.879f);

        //UI Emission
        UI.SetFloat("_redEmissionLevel", 1f);
        UI.SetFloat("_greenEmissionLevel", 0.706f);
        UI.SetFloat("_blueEmissionLevel", 1f);
        UI.SetFloat("_emissionPower", 0.43f);

        //Target Colour
        Target.SetFloat("_targetRed", 0.48f);
        Target.SetFloat("_targetGreen", 0f);
        Target.SetFloat("_targetBlue", 1f);
    }
}
