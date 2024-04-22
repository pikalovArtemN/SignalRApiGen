import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [vue()],
  build: {
    rollupOptions: {
      output: {
        dir: './dist',
        entryFileNames: 'signalr-api-gen.js',
        assetFileNames: 'signalr-api-gen.css',
        chunkFileNames: "chunk.js",
        manualChunks: undefined,
      }
    }
  }
})
