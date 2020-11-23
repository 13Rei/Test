using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    public Material backgroundMaterial;
    public Material playerMaterial;
    public Material obstacleMaterial;
    public Material UI;
    public Material Target;

    private void OnMouseUp()
    {
        //Background colour
        backgroundMaterial.SetFloat("_redLevel", 0.169f);
        backgroundMaterial.SetFloat("_greenLevel", 1f);
        backgroundMaterial.SetFloat("_blueLevel", 0.302f);

        //Obstacle colour
        obstacleMaterial.SetFloat("_albedoRedLevel", 0f);
        obstacleMaterial.SetFloat("_albedoGreenLevel", 0.205f);
        obstacleMaterial.SetFloat("_albedoBlueLevel", 0.061f);

        //obstacle Emission
        obstacleMaterial.SetFloat("_redEmissionLevel", 0.609f);
        obstacleMaterial.SetFloat("_greenEmissionLevel", 0.915f);
        obstacleMaterial.SetFloat("_blueEmissionLevel", 0.758f);
        obstacleMaterial.SetFloat("_emissionPower", 1.08f);

        //Player Colour
        playerMaterial.SetFloat("_redAlbedoLevel", 0f);
        playerMaterial.SetFloat("_greenAlbedoLevel", 0.322f);
        playerMaterial.SetFloat("_blueAlbedoLevel", 0);

        //Player Emission
        playerMaterial.SetFloat("_redEmissionLevel", 0f);
        playerMaterial.SetFloat("_greenEmissionLevel", 0.044f);
        playerMaterial.SetFloat("_blueEmissionLevel", 0f);
        playerMaterial.SetFloat("_emissionPower", 0.93f);

        //UI Colour
        UI.SetFloat("_redAlbedoLevel", 0f);
        UI.SetFloat("_greenAlbedoLevel", 0.459f);
        UI.SetFloat("_blueAlbedoLevel", 0f);

        //UI Emission
        UI.SetFloat("_redEmissionLevel", 0.157f);
        UI.SetFloat("_greenEmissionLevel", 0.568f);
        UI.SetFloat("_blueEmissionLevel", 0.137f);
        UI.SetFloat("_emissionPower", 0.42f);

        //Target Colour
        Target.SetFloat("_targetRed", 0f);
        Target.SetFloat("_targetGreen", 0.5f);
        Target.SetFloat("_targetBlue", 0f);
    }
}
