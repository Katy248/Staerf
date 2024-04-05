ProjectDir = Staerf.App

.PHONY: watch-app watch-css kill

watch-app:
	dotnet watch --project $(ProjectDir) --non-interactive

watch-css:
	cd $(ProjectDir) && \
		npx tailwindcss -i Styles/App.css -o wwwroot/css/app.css --watch --minify

kill: 
	killall dotnet Staerf.App npx npm
