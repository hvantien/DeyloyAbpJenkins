import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'AbpProject',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44355',
    redirectUri: baseUrl,
    clientId: 'AbpProject_App',
    responseType: 'code',
    scope: 'offline_access AbpProject',
  },
  apis: {
    default: {
      url: 'https://localhost:44355',
      rootNamespace: 'AbpProject',
    },
    AbpProject: {
      url: 'https://localhost:44326',
      rootNamespace: 'AbpProject',
    },
  },
} as Environment;
