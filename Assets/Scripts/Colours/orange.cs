using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orange : MonoBehaviour
{
    public Material backgroundMaterial;
    public Material playerMaterial;
    public Material obstacleMaterial;
    public Material UI;
    public Material Target;

    private void OnMouseUp()
    {
        //Background colour
        backgroundMaterial.SetFloat("_redLevel", 0.471f);
        backgroundMaterial.SetFloat("_greenLevel", 0.395f);
        backgroundMaterial.SetFloat("_blueLevel", 0.201f);

        //Obstacle colour
        obstacleMaterial.SetFloat("_albedoRedLevel", 0.657f);
        obstacleMaterial.SetFloat("_albedoGreenLevel", 0.064f);
        obstacleMaterial.SetFloat("_albedoBlueLevel", 0f);

        //obstacle Emission
        obstacleMaterial.SetFloat("_redEmissionLevel", 0.552f);
        obstacleMaterial.SetFloat("_greenEmissionLevel", 0.407f);
        obstacleMaterial.SetFloat("_blueEmissionLevel", 0f);
        obstacleMaterial.SetFloat("_emissionPower", 0.77f);

        //Player Colour
        playerMaterial.SetFloat("_redAlbedoLevel", 0.326f);
        playerMaterial.SetFloat("_greenAlbedoLevel", 0.262f);
        playerMaterial.SetFloat("_blueAlbedoLevel", 0f);

        //Player Emission
        playerMaterial.SetFloat("_redEmissionLevel", 0.093f);
        playerMaterial.SetFloat("_greenEmissionLevel", 0.068f);
        playerMaterial.SetFloat("_blueEmissionLevel", 0f);
        playerMaterial.SetFloat("_emissionPower", 4f);

        //UI Colour
        UI.SetFloat("_redAlbedoLevel", 0.588f);
        UI.SetFloat("_greenAlbedoLevel", 0.448f);
        UI.SetFloat("_blueAlbedoLevel", 0.153f);

        //UI Emission
        UI.SetFloat("_redEmissionLevel", 0.839f);
        UI.SetFloat("_greenEmissionLevel", 1f);
        UI.SetFloat("_blueEmissionLevel", 0f);
        UI.SetFloat("_emissionPower", 1.26f);

        //Target Colour
        Target.SetFloat("_targetRed", 0.5f);
        Target.SetFloat("_targetGreen", 0.5f);
        Target.SetFloat("_targetBlue", 0f);
    }
}
