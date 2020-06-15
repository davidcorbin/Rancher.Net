# Rancher API .Net Client Library

**Currently pre-alpha. Not yet ready for production use.**

## Example usage

```c#
RancherClient rancherClient = new RancherClient("https://<MYSITE>.com/", "token-asdf1:vv56tzz5pctk7kl2tldbnfblsjm7s.....");

// Get clusters
var clusters = rancherClient.Clusters().List().Result;

// Get kubeconfig file
var kubeconfigData = rancherClient.Clusters().GenerateKubeconfig("c-6asdf").Result;
```
