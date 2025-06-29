########################################
# Stage 1: Build
########################################
FROM node:22-alpine AS build
WORKDIR /frontend

# Only copy package manifests, install dependencies
COPY package*.json ./
RUN npm ci

# Copy source & build
COPY . .
RUN npm run build

########################################
# Stage 2: Serve with nginx
########################################
FROM nginx:stable-alpine

# Copy built from previous stage
COPY --from=build /frontend/dist /usr/share/nginx/html

EXPOSE 80

# Run nginx in foreground
CMD ["nginx", "-g", "daemon off;"]