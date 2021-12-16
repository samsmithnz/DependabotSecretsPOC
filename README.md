# DependabotSecretsPOC
A POC to confirm the best approach when managing secrets with Dependabot

Plan:
- [ ] Create a .NET test project. 
- [ ] Create a test that checks a secret for a specific value (e.g. abc123). 
- [ ] Confirm this test works locally.
- [ ] Confirm this test works in GitHub actions with a repo secret
- [ ] Create a Dependabot configuration
- [ ] Confirm this test works in GitHub actions with a dependabot secret (by adding some old nuget packages) 
