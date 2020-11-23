using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    public Material backgroundMaterial;
    public Material playerMaterial;
    public Material obstacleMaterial;
    public Material UI;
    public Material Target;

    private void OnMouseUp()
    {
        //Background colour
        backgroundMaterial.SetFloat("_redLevel", 1f);
        backgroundMaterial.SetFloat("_greenLevel", 0.201f);
        backgroundMaterial.SetFloat("_blueLevel", 0.201f);

        //Obstacle colour
        obstacleMaterial.SetFloat("_albedoRedLevel", 0.068f);
        obstacleMaterial.SetFloat("_albedoGreenLevel", 0f);
        obstacleMaterial.SetFloat("_albedoBlueLevel", 0f);

        //obstacle Emission
        obstacleMaterial.SetFloat("_redEmissionLevel", 1f);
        obstacleMaterial.SetFloat("_greenEmissionLevel", 0f);
        obstacleMaterial.SetFloat("_blueEmissionLevel", 0f);
        obstacleMaterial.SetFloat("_emissionPower", 0.82f);

        //Player Colour
        playerMaterial.SetFloat("_redAlbedoLevel", 0.27f);
        playerMaterial.SetFloat("_greenAlbedoLevel", 0f);
        playerMaterial.SetFloat("_blueAlbedoLevel", 0f);

        //Player Emission
        playerMaterial.SetFloat("_redEmissionLevel", 0.028f);
        playerMaterial.SetFloat("_greenEmissionLevel", 0f);
        playerMaterial.SetFloat("_blueEmissionLevel", 0f);
        playerMaterial.SetFloat("_emissionPower", 0.87f);

        //UI Colour
        UI.SetFloat("_redAlbedoLevel", 0.529f);
        UI.SetFloat("_greenAlbedoLevel", 0.145f);
        UI.SetFloat("_blueAlbedoLevel", 0.153f);

        //UI Emission
        UI.SetFloat("_redEmissionLevel", 1f);
        UI.SetFloat("_greenEmissionLevel", 0.612f);
        UI.SetFloat("_blueEmissionLevel", 0.621f);
        UI.SetFloat("_emissionPower", 0.74f);

        //Target Colour
        Target.SetFloat("_targetRed", 0.46f);
        Target.SetFloat("_targetGreen", 0f);
        Target.SetFloat("_targetBlue", 0f);
    }
}
