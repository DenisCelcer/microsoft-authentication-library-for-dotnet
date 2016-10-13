namespace Microsoft.Identity.Client
{
    /// <summary>
    /// Options how webview is displayed
    /// </summary>
    public class WebViewOptions
    {
        /// <summary>
        /// HTML that is displayed if web page can't be loaded
        /// </summary>
        public string ErrorHtml { set; get; }

        /// <summary>
        /// True if user has option to navigate back.
        /// </summary>
        public bool IsBackNavigationEnabled { set; get; } = true;
    }
}
