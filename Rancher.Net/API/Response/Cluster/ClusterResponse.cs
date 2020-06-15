namespace Rancher.Net.API.Response.Cluster
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public partial class ClusterResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public ClusterResponseLinks Links { get; set; }

        [JsonProperty("createTypes")]
        public CreateTypes CreateTypes { get; set; }

        [JsonProperty("actions")]
        public ClusterResponseActions Actions { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }
    }

    public partial class ClusterResponseActions
    {
        [JsonProperty("createFromTemplate")]
        public Uri CreateFromTemplate { get; set; }
    }

    public partial class CreateTypes
    {
        [JsonProperty("cluster")]
        public Uri Cluster { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("actions")]
        public DatumActions Actions { get; set; }

        [JsonProperty("agentFeatures", NullValueHandling = NullValueHandling.Ignore)]
        public AgentFeatures AgentFeatures { get; set; }

        [JsonProperty("agentImage")]
        public string AgentImage { get; set; }

        [JsonProperty("agentImageOverride")]
        public string AgentImageOverride { get; set; }

        [JsonProperty("allocatable")]
        public Allocatable Allocatable { get; set; }

        [JsonProperty("annotations")]
        public Annotations Annotations { get; set; }

        [JsonProperty("answers")]
        public Answers Answers { get; set; }

        [JsonProperty("apiEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ApiEndpoint { get; set; }

        [JsonProperty("appliedEnableNetworkPolicy")]
        public bool AppliedEnableNetworkPolicy { get; set; }

        [JsonProperty("appliedPodSecurityPolicyTemplateId")]
        public string AppliedPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("appliedSpec")]
        public AppliedSpec AppliedSpec { get; set; }

        [JsonProperty("authImage")]
        public string AuthImage { get; set; }

        [JsonProperty("baseType")]
        public string BaseType { get; set; }

        [JsonProperty("caCert", NullValueHandling = NullValueHandling.Ignore)]
        public string CaCert { get; set; }

        [JsonProperty("capabilities")]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("capacity")]
        public Allocatable Capacity { get; set; }

        [JsonProperty("certificatesExpiration", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, CertificatesExpiration> CertificatesExpiration { get; set; }

        [JsonProperty("clusterTemplateId")]
        public object ClusterTemplateId { get; set; }

        [JsonProperty("clusterTemplateRevisionId")]
        public object ClusterTemplateRevisionId { get; set; }

        [JsonProperty("componentStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public ComponentStatus[] ComponentStatuses { get; set; }

        [JsonProperty("conditions")]
        public DatumCondition[] Conditions { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("createdTS")]
        public long CreatedTs { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("defaultClusterRoleForProjectMembers")]
        public object DefaultClusterRoleForProjectMembers { get; set; }

        [JsonProperty("defaultPodSecurityPolicyTemplateId")]
        public object DefaultPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("desiredAgentImage")]
        public string DesiredAgentImage { get; set; }

        [JsonProperty("desiredAuthImage")]
        public string DesiredAuthImage { get; set; }

        [JsonProperty("dockerRootDir")]
        public string DockerRootDir { get; set; }

        [JsonProperty("driver")]
        public string Driver { get; set; }

        [JsonProperty("enableClusterAlerting")]
        public bool EnableClusterAlerting { get; set; }

        [JsonProperty("enableClusterMonitoring")]
        public bool EnableClusterMonitoring { get; set; }

        [JsonProperty("enableNetworkPolicy")]
        public bool? EnableNetworkPolicy { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("internal")]
        public bool Internal { get; set; }

        [JsonProperty("istioEnabled")]
        public bool IstioEnabled { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("limits")]
        public Allocatable Limits { get; set; }

        [JsonProperty("links")]
        public DatumLinks Links { get; set; }

        [JsonProperty("localClusterAuthEndpoint")]
        public LocalClusterAuthEndpoint LocalClusterAuthEndpoint { get; set; }

        [JsonProperty("monitoringStatus", NullValueHandling = NullValueHandling.Ignore)]
        public MonitoringStatus MonitoringStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nodeCount")]
        public long NodeCount { get; set; }

        [JsonProperty("nodeVersion")]
        public long NodeVersion { get; set; }

        [JsonProperty("rancherKubernetesEngineConfig", NullValueHandling = NullValueHandling.Ignore)]
        public RancherKubernetesEngineConfig RancherKubernetesEngineConfig { get; set; }

        [JsonProperty("requested")]
        public Allocatable Requested { get; set; }

        [JsonProperty("scheduledClusterScan", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduledClusterScan ScheduledClusterScan { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("transitioning")]
        public string Transitioning { get; set; }

        [JsonProperty("transitioningMessage")]
        public string TransitioningMessage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public Version Version { get; set; }

        [JsonProperty("windowsPreferedCluster")]
        public bool WindowsPreferedCluster { get; set; }
    }

    public partial class DatumActions
    {
        [JsonProperty("backupEtcd", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BackupEtcd { get; set; }

        [JsonProperty("disableMonitoring", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DisableMonitoring { get; set; }

        [JsonProperty("editMonitoring", NullValueHandling = NullValueHandling.Ignore)]
        public Uri EditMonitoring { get; set; }

        [JsonProperty("exportYaml", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ExportYaml { get; set; }

        [JsonProperty("generateKubeconfig")]
        public Uri GenerateKubeconfig { get; set; }

        [JsonProperty("importYaml")]
        public Uri ImportYaml { get; set; }

        [JsonProperty("restoreFromEtcdBackup", NullValueHandling = NullValueHandling.Ignore)]
        public Uri RestoreFromEtcdBackup { get; set; }

        [JsonProperty("rotateCertificates", NullValueHandling = NullValueHandling.Ignore)]
        public Uri RotateCertificates { get; set; }

        [JsonProperty("runSecurityScan", NullValueHandling = NullValueHandling.Ignore)]
        public Uri RunSecurityScan { get; set; }

        [JsonProperty("saveAsTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SaveAsTemplate { get; set; }

        [JsonProperty("viewMonitoring", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ViewMonitoring { get; set; }

        [JsonProperty("enableMonitoring", NullValueHandling = NullValueHandling.Ignore)]
        public Uri EnableMonitoring { get; set; }
    }

    public partial class AgentFeatures
    {
        [JsonProperty("dashboard")]
        public bool Dashboard { get; set; }
    }

    public partial class Allocatable
    {
        [JsonProperty("cpu")]
        public string Cpu { get; set; }

        [JsonProperty("memory")]
        public string Memory { get; set; }

        [JsonProperty("pods")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Pods { get; set; }
    }

    public partial class Annotations
    {
        [JsonProperty("authz.management.cattle.io/creator-role-bindings")]
        public string AuthzManagementCattleIoCreatorRoleBindings { get; set; }

        [JsonProperty("field.cattle.io/overwriteAppAnswers", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldCattleIoOverwriteAppAnswers { get; set; }

        [JsonProperty("lifecycle.cattle.io/create.cluster-agent-controller-cleanup")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool LifecycleCattleIoCreateClusterAgentControllerCleanup { get; set; }

        [JsonProperty("lifecycle.cattle.io/create.cluster-provisioner-controller", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? LifecycleCattleIoCreateClusterProvisionerController { get; set; }

        [JsonProperty("lifecycle.cattle.io/create.cluster-scoped-gc")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool LifecycleCattleIoCreateClusterScopedGc { get; set; }

        [JsonProperty("lifecycle.cattle.io/create.mgmt-cluster-rbac-remove")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool LifecycleCattleIoCreateMgmtClusterRbacRemove { get; set; }

        [JsonProperty("provisioner.cattle.io/ke-driver-update", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisionerCattleIoKeDriverUpdate { get; set; }

        [JsonProperty("io.cattle.agent.force.deploy", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? IoCattleAgentForceDeploy { get; set; }
    }

    public partial class Answers
    {
        [JsonProperty("clusterId")]
        public string ClusterId { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class AppliedSpec
    {
        [JsonProperty("agentImageOverride")]
        public string AgentImageOverride { get; set; }

        [JsonProperty("answers")]
        public Answers Answers { get; set; }

        [JsonProperty("clusterTemplateId")]
        public object ClusterTemplateId { get; set; }

        [JsonProperty("clusterTemplateRevisionId")]
        public object ClusterTemplateRevisionId { get; set; }

        [JsonProperty("defaultClusterRoleForProjectMembers")]
        public object DefaultClusterRoleForProjectMembers { get; set; }

        [JsonProperty("defaultPodSecurityPolicyTemplateId")]
        public object DefaultPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("desiredAgentImage")]
        public string DesiredAgentImage { get; set; }

        [JsonProperty("desiredAuthImage")]
        public string DesiredAuthImage { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dockerRootDir")]
        public string DockerRootDir { get; set; }

        [JsonProperty("enableClusterAlerting")]
        public bool EnableClusterAlerting { get; set; }

        [JsonProperty("enableClusterMonitoring")]
        public bool EnableClusterMonitoring { get; set; }

        [JsonProperty("enableNetworkPolicy")]
        public bool? EnableNetworkPolicy { get; set; }

        [JsonProperty("internal")]
        public bool Internal { get; set; }

        [JsonProperty("localClusterAuthEndpoint")]
        public LocalClusterAuthEndpoint LocalClusterAuthEndpoint { get; set; }

        [JsonProperty("rancherKubernetesEngineConfig", NullValueHandling = NullValueHandling.Ignore)]
        public RancherKubernetesEngineConfig RancherKubernetesEngineConfig { get; set; }

        [JsonProperty("scheduledClusterScan", NullValueHandling = NullValueHandling.Ignore)]
        public LocalClusterAuthEndpoint ScheduledClusterScan { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("windowsPreferedCluster")]
        public bool WindowsPreferedCluster { get; set; }
    }

    public partial class LocalClusterAuthEndpoint
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class RancherKubernetesEngineConfig
    {
        [JsonProperty("addonJobTimeout")]
        public long AddonJobTimeout { get; set; }

        [JsonProperty("authentication")]
        public Authentication Authentication { get; set; }

        [JsonProperty("authorization")]
        public Authorization Authorization { get; set; }

        [JsonProperty("bastionHost")]
        public BastionHost BastionHost { get; set; }

        [JsonProperty("cloudProvider")]
        public Authorization CloudProvider { get; set; }

        [JsonProperty("dns")]
        public Dns Dns { get; set; }

        [JsonProperty("ignoreDockerVersion")]
        public bool IgnoreDockerVersion { get; set; }

        [JsonProperty("ingress")]
        public Ingress Ingress { get; set; }

        [JsonProperty("kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        [JsonProperty("monitoring")]
        public Monitoring Monitoring { get; set; }

        [JsonProperty("network")]
        public Network Network { get; set; }

        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public Node[] Nodes { get; set; }

        [JsonProperty("privateRegistries")]
        public PrivateRegistry[] PrivateRegistries { get; set; }

        [JsonProperty("restore")]
        public Restore Restore { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("sshAgentAuth")]
        public bool SshAgentAuth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("upgradeStrategy")]
        public UpgradeStrategy UpgradeStrategy { get; set; }
    }

    public partial class Authentication
    {
        [JsonProperty("strategy")]
        public string Strategy { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Authorization
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class BastionHost
    {
        [JsonProperty("sshAgentAuth")]
        public bool SshAgentAuth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Dns
    {
        [JsonProperty("nodelocal")]
        public Nodelocal Nodelocal { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Nodelocal
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Ingress
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Monitoring
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("replicas")]
        public long Replicas { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Network
    {
        [JsonProperty("mtu")]
        public long Mtu { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }

        [JsonProperty("plugin")]
        public string Plugin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Options
    {
        [JsonProperty("flannel_backend_type")]
        public string FlannelBackendType { get; set; }
    }

    public partial class Node
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("hostnameOverride")]
        public string HostnameOverride { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("port")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Port { get; set; }

        [JsonProperty("role")]
        public string[] Role { get; set; }

        [JsonProperty("sshAgentAuth")]
        public bool SshAgentAuth { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public partial class PrivateRegistry
    {
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Restore
    {
        [JsonProperty("restore")]
        public bool RestoreRestore { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Services
    {
        [JsonProperty("etcd")]
        public Etcd Etcd { get; set; }

        [JsonProperty("kubeApi")]
        public KubeApi KubeApi { get; set; }

        [JsonProperty("kubeController")]
        public Authorization KubeController { get; set; }

        [JsonProperty("kubelet")]
        public Kubelet Kubelet { get; set; }

        [JsonProperty("kubeproxy")]
        public Authorization Kubeproxy { get; set; }

        [JsonProperty("scheduler")]
        public Authorization Scheduler { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Etcd
    {
        [JsonProperty("backupConfig")]
        public BackupConfig BackupConfig { get; set; }

        [JsonProperty("creation")]
        public string Creation { get; set; }

        [JsonProperty("extraArgs")]
        public ExtraArgs ExtraArgs { get; set; }

        [JsonProperty("gid")]
        public long Gid { get; set; }

        [JsonProperty("retention")]
        public string Retention { get; set; }

        [JsonProperty("snapshot")]
        public bool Snapshot { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }
    }

    public partial class BackupConfig
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("intervalHours")]
        public long IntervalHours { get; set; }

        [JsonProperty("retention")]
        public long Retention { get; set; }

        [JsonProperty("s3BackupConfig")]
        public object S3BackupConfig { get; set; }

        [JsonProperty("safeTimestamp")]
        public bool SafeTimestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ExtraArgs
    {
        [JsonProperty("election-timeout")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long ElectionTimeout { get; set; }

        [JsonProperty("heartbeat-interval")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long HeartbeatInterval { get; set; }
    }

    public partial class KubeApi
    {
        [JsonProperty("alwaysPullImages")]
        public bool AlwaysPullImages { get; set; }

        [JsonProperty("podSecurityPolicy")]
        public bool PodSecurityPolicy { get; set; }

        [JsonProperty("serviceNodePortRange")]
        public string ServiceNodePortRange { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Kubelet
    {
        [JsonProperty("failSwapOn")]
        public bool FailSwapOn { get; set; }

        [JsonProperty("generateServingCertificate")]
        public bool GenerateServingCertificate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class UpgradeStrategy
    {
        [JsonProperty("drain")]
        public bool Drain { get; set; }

        [JsonProperty("maxUnavailableControlplane")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long MaxUnavailableControlplane { get; set; }

        [JsonProperty("maxUnavailableWorker")]
        public string MaxUnavailableWorker { get; set; }

        [JsonProperty("nodeDrainInput")]
        public NodeDrainInput NodeDrainInput { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class NodeDrainInput
    {
        [JsonProperty("deleteLocalData")]
        public bool DeleteLocalData { get; set; }

        [JsonProperty("force")]
        public bool Force { get; set; }

        [JsonProperty("gracePeriod")]
        public long GracePeriod { get; set; }

        [JsonProperty("ignoreDaemonSets")]
        public bool IgnoreDaemonSets { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Capabilities
    {
        [JsonProperty("ingressCapabilities", NullValueHandling = NullValueHandling.Ignore)]
        public IngressCapability[] IngressCapabilities { get; set; }

        [JsonProperty("loadBalancerCapabilities")]
        public LoadBalancerCapabilities LoadBalancerCapabilities { get; set; }

        [JsonProperty("nodePoolScalingSupported")]
        public bool NodePoolScalingSupported { get; set; }

        [JsonProperty("nodePortRange", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePortRange { get; set; }

        [JsonProperty("pspEnabled")]
        public bool PspEnabled { get; set; }

        [JsonProperty("taintSupport", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TaintSupport { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class IngressCapability
    {
        [JsonProperty("customDefaultBackend")]
        public bool CustomDefaultBackend { get; set; }

        [JsonProperty("ingressProvider")]
        public string IngressProvider { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class LoadBalancerCapabilities
    {
        [JsonProperty("healthCheckSupported")]
        public bool HealthCheckSupported { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class CertificatesExpiration
    {
        [JsonProperty("expirationDate")]
        public DateTimeOffset ExpirationDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ComponentStatus
    {
        [JsonProperty("conditions")]
        public ComponentStatusCondition[] Conditions { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ComponentStatusCondition
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class DatumCondition
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("lastUpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdateTime { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }
    }

    public partial class Labels
    {
        [JsonProperty("cattle.io/creator")]
        public string CattleIoCreator { get; set; }
    }

    public partial class DatumLinks
    {
        [JsonProperty("apiServices")]
        public Uri ApiServices { get; set; }

        [JsonProperty("clusterAlertGroups")]
        public Uri ClusterAlertGroups { get; set; }

        [JsonProperty("clusterAlertRules")]
        public Uri ClusterAlertRules { get; set; }

        [JsonProperty("clusterAlerts")]
        public Uri ClusterAlerts { get; set; }

        [JsonProperty("clusterCatalogs")]
        public Uri ClusterCatalogs { get; set; }

        [JsonProperty("clusterLoggings")]
        public Uri ClusterLoggings { get; set; }

        [JsonProperty("clusterMonitorGraphs")]
        public Uri ClusterMonitorGraphs { get; set; }

        [JsonProperty("clusterRegistrationTokens")]
        public Uri ClusterRegistrationTokens { get; set; }

        [JsonProperty("clusterRoleTemplateBindings")]
        public Uri ClusterRoleTemplateBindings { get; set; }

        [JsonProperty("clusterScans")]
        public Uri ClusterScans { get; set; }

        [JsonProperty("etcdBackups")]
        public Uri EtcdBackups { get; set; }

        [JsonProperty("namespaces")]
        public Uri Namespaces { get; set; }

        [JsonProperty("nodePools")]
        public Uri NodePools { get; set; }

        [JsonProperty("nodes")]
        public Uri Nodes { get; set; }

        [JsonProperty("notifiers")]
        public Uri Notifiers { get; set; }

        [JsonProperty("persistentVolumes")]
        public Uri PersistentVolumes { get; set; }

        [JsonProperty("projects")]
        public Uri Projects { get; set; }

        [JsonProperty("remove", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Remove { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("shell")]
        public string Shell { get; set; }

        [JsonProperty("storageClasses")]
        public Uri StorageClasses { get; set; }

        [JsonProperty("subscribe")]
        public Uri Subscribe { get; set; }

        [JsonProperty("templates")]
        public Uri Templates { get; set; }

        [JsonProperty("tokens")]
        public Uri Tokens { get; set; }

        [JsonProperty("update")]
        public Uri Update { get; set; }
    }

    public partial class MonitoringStatus
    {
        [JsonProperty("conditions")]
        public MonitoringStatusCondition[] Conditions { get; set; }

        [JsonProperty("grafanaEndpoint")]
        public string GrafanaEndpoint { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class MonitoringStatusCondition
    {
        [JsonProperty("lastUpdateTime")]
        public DateTimeOffset LastUpdateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ScheduledClusterScan
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scanConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ScanConfig ScanConfig { get; set; }

        [JsonProperty("scheduleConfig", NullValueHandling = NullValueHandling.Ignore)]
        public ScheduleConfig ScheduleConfig { get; set; }
    }

    public partial class ScanConfig
    {
        [JsonProperty("cisScanConfig")]
        public CisScanConfig CisScanConfig { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class CisScanConfig
    {
        [JsonProperty("debugMaster")]
        public bool DebugMaster { get; set; }

        [JsonProperty("debugWorker")]
        public bool DebugWorker { get; set; }

        [JsonProperty("overrideBenchmarkVersion")]
        public string OverrideBenchmarkVersion { get; set; }

        [JsonProperty("overrideSkip")]
        public object OverrideSkip { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ScheduleConfig
    {
        [JsonProperty("cronSchedule")]
        public string CronSchedule { get; set; }

        [JsonProperty("retention")]
        public long Retention { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Version
    {
        [JsonProperty("buildDate")]
        public DateTimeOffset BuildDate { get; set; }

        [JsonProperty("compiler")]
        public string Compiler { get; set; }

        [JsonProperty("gitCommit")]
        public string GitCommit { get; set; }

        [JsonProperty("gitTreeState")]
        public string GitTreeState { get; set; }

        [JsonProperty("gitVersion")]
        public string GitVersion { get; set; }

        [JsonProperty("goVersion")]
        public string GoVersion { get; set; }

        [JsonProperty("major")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Major { get; set; }

        [JsonProperty("minor")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Minor { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class Filters
    {
        [JsonProperty("agentImage")]
        public object AgentImage { get; set; }

        [JsonProperty("agentImageOverride")]
        public object AgentImageOverride { get; set; }

        [JsonProperty("apiEndpoint")]
        public object ApiEndpoint { get; set; }

        [JsonProperty("appliedEnableNetworkPolicy")]
        public object AppliedEnableNetworkPolicy { get; set; }

        [JsonProperty("appliedPodSecurityPolicyTemplateId")]
        public object AppliedPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("authImage")]
        public object AuthImage { get; set; }

        [JsonProperty("caCert")]
        public object CaCert { get; set; }

        [JsonProperty("clusterTemplateId")]
        public object ClusterTemplateId { get; set; }

        [JsonProperty("clusterTemplateRevisionId")]
        public object ClusterTemplateRevisionId { get; set; }

        [JsonProperty("created")]
        public object Created { get; set; }

        [JsonProperty("creatorId")]
        public object CreatorId { get; set; }

        [JsonProperty("currentCisRunName")]
        public object CurrentCisRunName { get; set; }

        [JsonProperty("defaultClusterRoleForProjectMembers")]
        public object DefaultClusterRoleForProjectMembers { get; set; }

        [JsonProperty("defaultPodSecurityPolicyTemplateId")]
        public object DefaultPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("desiredAgentImage")]
        public object DesiredAgentImage { get; set; }

        [JsonProperty("desiredAuthImage")]
        public object DesiredAuthImage { get; set; }

        [JsonProperty("dockerRootDir")]
        public object DockerRootDir { get; set; }

        [JsonProperty("driver")]
        public object Driver { get; set; }

        [JsonProperty("enableClusterAlerting")]
        public object EnableClusterAlerting { get; set; }

        [JsonProperty("enableClusterMonitoring")]
        public object EnableClusterMonitoring { get; set; }

        [JsonProperty("enableNetworkPolicy")]
        public object EnableNetworkPolicy { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("internal")]
        public object Internal { get; set; }

        [JsonProperty("istioEnabled")]
        public object IstioEnabled { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("nodeCount")]
        public object NodeCount { get; set; }

        [JsonProperty("nodeVersion")]
        public object NodeVersion { get; set; }

        [JsonProperty("removed")]
        public object Removed { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("transitioning")]
        public object Transitioning { get; set; }

        [JsonProperty("transitioningMessage")]
        public object TransitioningMessage { get; set; }

        [JsonProperty("uuid")]
        public object Uuid { get; set; }

        [JsonProperty("windowsPreferedCluster")]
        public object WindowsPreferedCluster { get; set; }
    }

    public partial class ClusterResponseLinks
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class Sort
    {
        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("reverse")]
        public Uri Reverse { get; set; }

        [JsonProperty("links")]
        public SortLinks Links { get; set; }
    }

    public partial class SortLinks
    {
        [JsonProperty("agentImage")]
        public Uri AgentImage { get; set; }

        [JsonProperty("agentImageOverride")]
        public Uri AgentImageOverride { get; set; }

        [JsonProperty("apiEndpoint")]
        public Uri ApiEndpoint { get; set; }

        [JsonProperty("appliedPodSecurityPolicyTemplateId")]
        public Uri AppliedPodSecurityPolicyTemplateId { get; set; }

        [JsonProperty("authImage")]
        public Uri AuthImage { get; set; }

        [JsonProperty("caCert")]
        public Uri CaCert { get; set; }

        [JsonProperty("currentCisRunName")]
        public Uri CurrentCisRunName { get; set; }

        [JsonProperty("description")]
        public Uri Description { get; set; }

        [JsonProperty("desiredAgentImage")]
        public Uri DesiredAgentImage { get; set; }

        [JsonProperty("desiredAuthImage")]
        public Uri DesiredAuthImage { get; set; }

        [JsonProperty("dockerRootDir")]
        public Uri DockerRootDir { get; set; }

        [JsonProperty("driver")]
        public Uri Driver { get; set; }

        [JsonProperty("state")]
        public Uri State { get; set; }

        [JsonProperty("transitioning")]
        public Uri Transitioning { get; set; }

        [JsonProperty("transitioningMessage")]
        public Uri TransitioningMessage { get; set; }

        [JsonProperty("uuid")]
        public Uri Uuid { get; set; }
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }
}
