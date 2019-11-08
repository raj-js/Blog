export default {
    authority: 'https://localhost:5001',
    client_id: 'js_client',
    redirect_uri: `${window.location.origin}/oidc-callback`,
    popupRedirectUri: `${window.location.origin}/oidc-popup-callback`,
    response_mode: 'query',
    response_type: 'code',
    scope: 'openid profile',
    automaticSilentRenew: true,
	silentRedirectUri: `${window.location.origin}/silent-renew-oidc.html`
}