namespace Xiaoheihe_Core.Data
{
    /// <summary>
    /// 关注状态
    /// </summary>
    public enum FollowStatus
    {
        Unknown = 0,
        /// <summary>主动关注</summary>
        IFollowHe = 1,
        /// <summary>被别人关注</summary>
        HeFollowI = 2,
        /// <summary>互相关注</summary>
        MutualFollow = 3,
    }
}
